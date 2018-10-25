const webpack = require('webpack');
const webpackMerge = require('webpack-merge');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const FaviconsWebpackPlugin = require('favicons-webpack-plugin');
const CopyWebpackPlugin = require('copy-webpack-plugin');
const commonConfig = require('./webpack.common.js');
const helpers = require('./helpers');

const ENV = process.env.NODE_ENV = process.env.ENV = 'production';

module.exports = webpackMerge.smartStrategy({
    entry: 'replace',
    'module.rules': 'prepend'
})(commonConfig, {
    output: {
        path: helpers.root('dist'),
        publicPath: '',
        filename: '[name].[hash].js'
    },

    optimization: {
        splitChunks: {
            cacheGroups: {
                commons: {
                    test: /[\\/]node_modules[\\/]/,
                    name: 'vendor',
                    chunks: "all"
                }
            }
        },
        minimizer: [
            new UglifyJsPlugin({
                sourceMap: false
            })
        ]
    },

    plugins: [
        new webpack.NoEmitOnErrorsPlugin(),
        new ExtractTextPlugin('[name].[hash].css'),
        new HtmlWebpackPlugin({
            template: 'public/index.html'
        }),
        new FaviconsWebpackPlugin(helpers.root('public/favicon.png')),
        new CopyWebpackPlugin([{
            from: helpers.root('public/img/*'),
            to: 'img/'
        }]),
        new webpack.DefinePlugin({
            'process.env': {
                'NODE_ENV': JSON.stringify(ENV)
            }
        })
    ]
});
