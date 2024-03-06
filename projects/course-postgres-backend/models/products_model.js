const Pool = require('pg').Pool

const pool = new Pool({
    user: 'danii',
    host: 'localhost',
    database: 'MyNorthwind',
    password: '',
    port: 5432,
});

const getProducts = () => {
    return new Promise(function (resolve, reject) {
        pool.query('SELECT * FROM products', (error, results) => {
            if (error) {
                reject(error)
            }
            resolve(results.rows);
        })
    })
}

const createProduct = (body) => {
    return new Promise(function (resolve, reject) {
        const {
            product_id,
            product_name,
            supplier_id,
            category_id,
            quantity_per_unit,
            unit_price,
            units_in_stock,
            units_on_order,
            reorder_level,
            discontinued
        } = body
        pool.query('INSERT INTO products (product_id, product_name, supplier_id, category_id, quantity_per_unit, unit_price, ' +
            'units_in_stock, units_on_order, reorder_level, discontinued) \n' +
            'VALUES ($1, $2, $3, $4, $5, $6, $7, $8, $9, $10);',
            [product_id, product_name, supplier_id, category_id, quantity_per_unit, unit_price, units_in_stock, units_on_order, reorder_level, discontinued],
            (error, results) => {
                console.log(error?.message);
                // console.log(results);
                if (error) {
                    reject(error?.message)
                }
                if (results?.rowCount === 0) {
                    reject("Couldn't create a new product")
                }
                resolve({success: true, data: `A new product has been added.`})
            })
    })
}
const deleteProduct = (id) => {
    return new Promise(function (resolve, reject) {
        console.log(id);
        pool.query('DELETE FROM products WHERE product_id = $1', [id], (error, results) => {
            console.log(results);
            if (error) {
                console.log(error);
                reject(error)
            }
            else if (results?.rowCount === 0) {
                reject(`Couldn't delete, there is no product with ${id} id`)
            } else resolve({success: true, data: `Product deleted with ID: ${id}`})
        })
    })
}

module.exports = {
    getProducts,
    createProduct,
    deleteProduct,
}
