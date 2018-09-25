const webpackMerge = require('webpack-merge');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const ExtractTextPlugin = require('extract-text-webpack-plugin');
const CopyWebpackPlugin = require('copy-webpack-plugin');

const commonConfig = require('./webpack.common.js');
const helpers = require('./helpers');

module.exports = webpackMerge(commonConfig, {
    devtool: 'source-map',

    output: {
        path: helpers.root('dist'),
        publicPath: 'http://localhost:3000/',
        filename: '[name].js',
    },

    optimization: {
        namedModules: true
    },
    plugins: [
        new ExtractTextPlugin('[name].css'),
        new HtmlWebpackPlugin({
            template: 'public/index.html'
        })
    ],

    devServer: {
        contentBase: helpers.root('./public'),
        historyApiFallback: true,
        stats: 'minimal'
    }
});
