import {createApi, fetchBaseQuery} from "@reduxjs/toolkit/query/react";
import {IProduct} from "./types";

export const productsApi = createApi({
        reducerPath: "productsApi",
        baseQuery: fetchBaseQuery({baseUrl: "http://localhost:3001"}),
        tagTypes: ['Product'],
        endpoints: (builder) => ({
            getProducts: builder.query<IProduct[], string>({
                query: () => `/products`,
                providesTags: result => ['Product']
            }),
            createProduct: builder.mutation<IProduct, Partial<IProduct>>({
                query: (body) => ({
                    url: `/products/create`,
                    method: 'POST',
                    body,
                }),
                invalidatesTags: result => ['Product'],
            }),
            deleteProduct: builder.mutation<{ success: boolean; id: number }, number>({
                query: (id) => ({
                    url: `/products/${id}`,
                    method: 'DELETE',
                }),
                invalidatesTags: result => ['Product'],
            }),
        }),
    }
);

export const {useGetProductsQuery, useCreateProductMutation, useDeleteProductMutation} = productsApi;
