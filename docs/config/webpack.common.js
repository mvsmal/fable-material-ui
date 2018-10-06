const ExtractTextPlugin = require('extract-text-webpack-plugin');

const helpers = require('./helpers');

const isProduction = process.argv.indexOf("-p") >= 0;
console.log("Bundling for " + (isProduction ? "production" : "development") + "...");

const babelOptions = {
    presets: [
        ["@babel/preset-env", {
            "targets": {
                "browsers": [
                    "last 3 versions",
                    "ie >= 9"
                ]
            },
            "modules": false
        }]
    ],
    plugins: [
        ["prismjs", {
            "languages": ["fsharp", "bash", "markdown", "markup"],
            "theme": "default",
            "css": true
        }]
    ]
};
module.exports = {
    entry: {
        'index': './src/Fable.MaterialUI.Docs.fsproj',
    },
    resolve: {
        // See https://github.com/fable-compiler/Fable/issues/1490
        symlinks: false,
        modules: [helpers.root("./node_modules/")]
    },

    module: {
        rules: [{
                test: /\.fs(x|proj)?$/,
                use: {
                    loader: "fable-loader",
                    options: {
                        define: isProduction ? [] : ["DEBUG"]
                    }
                }
            },
            {
                test: /\.(png|jpe?g|gif|svg|woff|woff2|ttf|eot|ico)$/,
                use: [{ loader: 'file-loader', options: { name: '[name].[hash].[ext]', outputPath: 'assets/' } }]
            },
            {
                test: /\.md$/,
                use: [ "raw-loader" ]
            },
            {
                test: /\.js$/,
                exclude: /node_modules/,
                use: {
                    loader: 'babel-loader',
                    options: babelOptions
                },
            },
            {
                test: /.sass$/,
                use: ExtractTextPlugin.extract({
                    fallback: 'style-loader',
                    use: ["css-loader", "sass-loader"]
                })
            },
            {
                test: /.css$/,
                use: ExtractTextPlugin.extract({
                    fallback: 'style-loader',
                    use: ['css-loader']
                })
            }
        ]
    },
};
