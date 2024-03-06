const db_config = require('../config/db')
const {
    CREATE_BOOK_QUERY,
    DELETE_BOOK_QUERY,
    GET_ALL_BOOK_QUERY,
    GET_BOOK_QUERY,
    UPDATE_BOOK_QUERY
} = require('../config/queries');

const Pool = require('pg').Pool
const pool = new Pool(db_config);

exports.getAllBooks = () => {
    return new Promise(function (resolve, reject) {
        pool.query(GET_ALL_BOOK_QUERY, (error, results) => {
            if (error) reject(error);
            resolve(results.rows);
        })
    })
}

exports.getBook = (id) => {
    return new Promise(function (resolve, reject) {
        pool.query(GET_BOOK_QUERY, [id], (error, results) => {
            if (error) reject(error);
            resolve(results.rows[0]);
        })
    })
}

exports.createBook = (body) => {
    return new Promise(function (resolve, reject) {
        const { title, author } = body
        pool.query(CREATE_BOOK_QUERY, [title, author],
            (error, results) => {
                if (error) reject(error?.message);
                if (results?.rowCount === 0) reject("Couldn't create a new book")
                resolve({success: true, data: `A new book has been added.`})
            })
    })
}

exports.updateBook = (id, body) => {
    return new Promise(function (resolve, reject) {
        const { title, author } = body
        pool.query(UPDATE_BOOK_QUERY, [title, author, id],
            (error, results) => {
                if (error) reject(error?.message);
                if (results?.rowCount === 0) reject("Couldn't create a new book")
                resolve({success: true, data: `A new book has been updated.`})
            })
    })
}

exports.deleteBook = (id) => {
    return new Promise(function (resolve, reject) {
        pool.query(DELETE_BOOK_QUERY, [id], (error, results) => {
            if (error) reject(error);
            else if (results?.rowCount === 0) reject(`Couldn't delete, there is no book with ${id} id`);
            else resolve({success: true, data: `Book with ID: ${id} was deleted`});
        })
    })
}
