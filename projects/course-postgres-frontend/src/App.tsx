import React, {FormEvent, useMemo, useState} from "react";
import {Table} from "./shared/Table";
import {useCreateProductMutation, useDeleteProductMutation, useGetProductsQuery} from "./app/products/api";
import AppBar from './view/AppBar';
import {SEARCH_FIELDS} from './constants/search';
import {IProduct} from './app/products/types';
import {ClausHero} from './animations/ClausHero';
import Search from './view/Search';
import {useImmer} from 'use-immer';
import {FormInput, IFormInput} from './view/FormInput';
import {toast, ToastContainer} from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import {FetchBaseQueryError} from '@reduxjs/toolkit/query';

const initialNewProduct: IProduct = {
    category_id: 0,
    discontinued: 0,
    product_name: '',
    quantity_per_unit: '',
    reorder_level: 0,
    supplier_id: 0,
    unit_price: 0,
    units_in_stock: 0,
    units_on_order: 0,
    product_id: 0
}

function App() {
    const {data: products = [], isLoading, error} = useGetProductsQuery("");
    const [createProduct, {error: createError}] = useCreateProductMutation()
    const [deleteProduct, {error: deleteError}] = useDeleteProductMutation()

    const [searchRequest, setSearchRequest] = useState('');
    const [searchField, setSearchField] = useState(SEARCH_FIELDS[0]);

    const filteredProducts =
        (searchRequest?.length > 0) ?
            products.filter((product: IProduct) =>
                String(product[searchField])?.includes(searchRequest))
            : products

    const [newProduct, setNewProduct] = useImmer(initialNewProduct);
    const [deleteId, setDeleteId] = useState(0);

    const submitAddNewProduct = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        console.log(newProduct);

        await createProduct(newProduct).unwrap()
            .then(() => {
                toast.success("New product was added successfully");
                setNewProduct(initialNewProduct);
            })
            .catch((err: FetchBaseQueryError) => {
                console.log(err);
                toast.error(`An error has occurred: ${err.data}`);
            });
    }

    const submitDeleteProduct = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        console.log(deleteId);

        await deleteProduct(deleteId).unwrap()
            .then(() => {
                toast.success(`Product ${deleteId} was deleted successfully`);
                setDeleteId(0);
            })
            .catch((err: FetchBaseQueryError) => {
                console.log(err);
                toast.error(`An error has occurred: ${err.data}`);
            });
    }

    const ADD_INPUTS = useMemo((): IFormInput[] => [
            {
                id: 'input-form-0',
                label_text: 'Product ID',
                type: 'number',
                placeholder: '123',
                value: newProduct.product_id,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.product_id = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-1',
                label_text: 'Product name',
                type: 'text',
                placeholder: 'Super-duper dinosaur',
                value: newProduct.product_name,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.product_name = e.target.value
                }),
            },
            {
                id: 'input-form-2',
                label_text: 'Supplier ID',
                type: 'number',
                placeholder: '1',
                value: newProduct.supplier_id ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.supplier_id = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-3',
                label_text: 'Category ID',
                type: 'number',
                placeholder: '1',
                value: newProduct.category_id ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.category_id = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-4',
                label_text: 'Quantity per unit',
                type: 'text',
                placeholder: '10 boxes x 30 bags"',
                value: newProduct.quantity_per_unit ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.quantity_per_unit = e.target.value
                }),
            },
            {
                id: 'input-form-5',
                label_text: 'Unit price',
                type: 'number',
                placeholder: 'Free!',
                value: newProduct.unit_price ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.unit_price = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-6',
                label_text: 'Units in stock',
                type: 'number',
                placeholder: 'Millions...',
                value: newProduct.units_in_stock ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.units_in_stock = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-7',
                label_text: 'Unit on order',
                type: 'number',
                placeholder: 'Exactly...',
                value: newProduct.units_on_order ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.units_on_order = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-8',
                label_text: 'Reorder level',
                type: 'number',
                placeholder: '0',
                value: newProduct.reorder_level ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.reorder_level = parseInt(e.target.value)
                }),
            },
            {
                id: 'input-form-9',
                label_text: 'Discontinued',
                type: 'number',
                placeholder: '0',
                value: newProduct.discontinued ?? 0,
                onChange: (e: React.ChangeEvent<HTMLInputElement>) => setNewProduct(product => {
                    product.discontinued = parseInt(e.target.value)
                }),
            },
        ],
        [newProduct.category_id, newProduct.discontinued, newProduct.product_id, newProduct.product_name, newProduct.quantity_per_unit, newProduct.reorder_level, newProduct.supplier_id, newProduct.unit_price, newProduct.units_in_stock, newProduct.units_on_order, setNewProduct]);

    if (error) {
        return <div>error...</div>;
    }

    if (isLoading) {
        return <div>Loading...</div>;
    }

    return (
        <div className="grid gap-12 p-4">
            <AppBar/>
            <div className="grid h-[800px]">
                <ClausHero/>
            </div>
            <div className='flex justify-around'>
                <label htmlFor="add-product-modal" className="btn">Add new product</label>
                {/* Add Product Modal */}
                <input type="checkbox" id="add-product-modal" className="modal-toggle"/>
                <label htmlFor="add-product-modal" className="modal cursor-pointer">
                    <form className="modal-box relative grid gap-4 grid-cols-2" onSubmit={submitAddNewProduct}>

                        {ADD_INPUTS.map((inp, ind) => <FormInput
                            placeholder={inp.placeholder}
                            key={inp.id}
                            label_text={inp.label_text}
                            type={inp.type}
                            value={inp.value}
                            onChange={inp.onChange}/>
                        )}

                        <button className="btn btn-accent col-span-2">Submit</button>
                    </form>
                </label>

                <Search searchField={searchField}
                        searchRequest={searchRequest}
                        setSearchRequest={setSearchRequest}
                        setSearchField={setSearchField}/>

                <label htmlFor="delete-product-modal" className="btn">Delete product</label>
                {/* Add Product Modal */}
                <input type="checkbox" id="delete-product-modal" className="modal-toggle"/>
                <label htmlFor="delete-product-modal" className="modal cursor-pointer">
                    <form className="modal-box relative grid gap-4" onSubmit={submitDeleteProduct}>
                        {/* ID */}
                        <div className="form-control w-full max-w-xs">
                            <label className="label">
                                <span className="label-text">Product ID</span>
                            </label>
                            <input type="number"
                                   min={0}
                                   placeholder="123"
                                   value={deleteId}
                                   onChange={(e: React.ChangeEvent<HTMLInputElement>) => setDeleteId(parseInt(e.target.value))}
                                   className="input input-bordered w-full max-w-xs"/>
                        </div>

                        <button className="btn btn-accent">Submit</button>
                    </form>
                </label>
            </div>
            <div>
                <h1 className="text-md">Products</h1>
                <Table data={filteredProducts}/>
            </div>
            <ToastContainer
                position="bottom-right"
                autoClose={5000}
                hideProgressBar={false}
                newestOnTop={false}
                closeOnClick
                rtl={false}
                pauseOnFocusLoss
                draggable
                pauseOnHover
                theme="light"
            />
        </div>
    );
}

export default App;
