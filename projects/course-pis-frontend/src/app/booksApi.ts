import {createApi, fetchBaseQuery} from "@reduxjs/toolkit/query/react";
import {IBook} from "./types";

const TAG = 'Books';
const endpoint = '/books';

export const booksApi = createApi({
        reducerPath: "booksApi",
        baseQuery: fetchBaseQuery({baseUrl: "http://localhost:3001"}),
        tagTypes: [TAG],
        endpoints: (builder) => ({
            getAll: builder.query<IBook[], string>({
                query: () => `${endpoint}`,
                providesTags: (result) =>
                    result
                        ? [
                            ...result.map(({ book_id }) => ({ type: TAG, book_id } as const)),
                            { type: TAG, id: 'LIST' },
                        ]
                        : [{ type: TAG, id: 'LIST' }],
            }),
            get: builder.query<IBook, string>({
                query: (id) => `${endpoint}/${id}`,
                providesTags: (result, error, id) => [{ type: TAG, id }],
            }),
            create: builder.mutation<IBook, Partial<IBook>>({
                query: (body) => ({
                    url: `${endpoint}`,
                    method: 'POST',
                    body,
                }),
                invalidatesTags: (result, error, { book_id }) => [{ type: TAG, book_id }],
            }),
            update: builder.mutation<IBook, Partial<IBook>>({
                query: (data) => {
                    const { book_id, ...body } = data;

                    return ({
                        url: `${endpoint}/${book_id}`,
                        method: 'POST',
                        body,
                    })
                },
                invalidatesTags: (result, error, { book_id }) => [{ type: TAG, book_id }],
            }),
            delete: builder.mutation<{ success: boolean; id: number }, number>({
                query: (id) => ({
                    url: `${endpoint}/${id}`,
                    method: 'DELETE',
                }),
                invalidatesTags: () => [{ type: TAG}],
            }),
        }),
    }
);

export const {useCreateMutation, useDeleteMutation, useUpdateMutation, useGetAllQuery, useGetQuery} = booksApi;
