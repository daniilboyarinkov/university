export interface IProduct {
    product_id: number;
    product_name: string;
    supplier_id?: number;
    category_id?: number;
    quantity_per_unit?: string;
    unit_price: number;
    units_in_stock: number;
    units_on_order: number;
    reorder_level?: number;
    discontinued: number;
}
