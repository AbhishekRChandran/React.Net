var config = {
    entry: './wwwroot/index.js',
    output: {
        filename: './wwwroot/bundle.js'
    },
    module : {
        loaders: [
            {
                test: /\.js?/,
                //include: APP_DIR,
                loader: 'babel',
                exclude: /(node_modules)/,
            },
            {
                test: /\.jsx?/,
                //include: APP_DIR,
                loader: 'babel',
                exclude: /(node_modules)/,
            },
            {
                test: /\.json$/,
                exclude: /(node_modules)/,
                loader: 'json-loader'
            }
        ]
    }
};

module.exports = config;
