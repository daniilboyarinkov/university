import {IProduct} from '../app/products/types';

export type TSearchField = keyof IProduct;
export const SEARCH_FIELDS: TSearchField[] = [
    'category_id',
    'product_name',
    'discontinued',
];
