

        'use strict';

var express = require('express');
    var app = express();
    var formidable = require('formidable');
    var math = require('./math_example');

    const port = process.env.PORT || 1337;
    const rootDir = __dirname + '/wwwroot';

    app.use(express.static(rootDir));

    app.get('/addition', function (request, response) {
        var x = Number(request.query.x),
            y = Number(request.query.y),
            result = math.addition(x, y);
        response.writeHead(200, { 'Content-Type': 'application/json' });
        response.end('{ "result": ' + result + '}');
        console.log('Handled addition request for x=' + x + ' : y=' + y);
    });

    app.listen(port);

    