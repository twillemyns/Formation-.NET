import {configureStore} from "@reduxjs/toolkit";
import productSlice from "./components/products/productSlice.js";

export default configureStore({
    reducer: {
        product: productSlice
    }
})