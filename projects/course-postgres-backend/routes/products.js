const express = require('express');
const router = express.Router();
const products_model = require('../models/products_model.js');

/* GET users listing. */
router.get('/', function (req, res, next) {
    products_model.getProducts()
        .then(response => {
            res.status(200).send(response);
        })
        .catch(error => {
            res.status(500).send(error);
        })
});

router.post('/create', function (req, res, next) {
    products_model.createProduct(req.body)
        .then(response => {
            res.status(200).send(response);
        })
        .catch(error => {
            console.log(error);
            res.status(500).send(error);
        })
});

router.delete('/:id', function (req, res, next) {
    products_model.deleteProduct(req.params.id)
        .then(response => {
            res.status(200).send(response);
        })
        .catch(error => {
            console.log(error);
            res.status(500).send(error);
        })
});

module.exports = router;
