import {createSlice} from "@reduxjs/toolkit";

const productSlice = createSlice({
    name: "products",
    initialState: {
        products: [{
            id: crypto.randomUUID(),
            name: "Casque Audio",
            price: 100
        }]
    },
    reducers: {
        addProduct: (state, action) => {
            const newProduct = {
                id: crypto.randomUUID(),
                name: action.payload.name,
                price: action.payload.price
            }
            state.products.push(newProduct);
        },
        removeProduct: (state, action) => {
            state.products.splice(state.products.indexOf(action.payload), 1);
        },
        updateProduct: (state, action) => {
            const product = state.products.find(p => p.id === action.payload.id);

            if (product) {
                product.name = action.payload.name;
                product.price = action.payload.price;
                state.products.push(product);
            }else {
                console.log("Produit non trouvé");
            }
        }
    }
})

export const {addProduct, removeProduct, updateProduct} = productSlice.actions;

export default productSlice.reducer;