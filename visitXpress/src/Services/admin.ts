import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';

export const adminApi = createApi({
  reducerPath: 'adminApi',
  baseQuery: fetchBaseQuery({ baseUrl: 'https://example.com' }),
  endpoints: (builder) => ({
    getUsers: builder.query({
      query: () => '/users'
    }),
  }),
});

export const { useGetUsersQuery } = adminApi;
