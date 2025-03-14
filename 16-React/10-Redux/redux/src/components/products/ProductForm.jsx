import {useDispatch} from "react-redux";
import {addProduct, updateProduct} from "./productSlice.js";
import {createPortal} from "react-dom";

const ProductForm = ({product}) => {

    console.log("entrée module")

    const dispatch = useDispatch();

    const formSubmit = (formData) => {
        if (!product) {
            const newProduct = {
                id: crypto.randomUUID(), name: formData.get("name"), price: formData.get("price")
            };

            dispatch(addProduct(newProduct));
        } else {

            dispatch(updateProduct(product));
        }
    };

    return createPortal(
        <div>
            <div id="form" data-uk-modal>
                <div className="uk-modal-dialog uk-modal-body">
                    <h2 className="uk-modal-title"></h2>
                    <form onSubmit={formSubmit}>
                        <div>
                            <label htmlFor="name" className="form-label">Nom du produit</label>
                            <input type="text" name='name' className="form-control"
                                   defaultValue={product?.name}/>
                        </div>
                        <div>
                            <label htmlFor="price" className="form-label">Prix</label>
                            <input type="currency" name='price' className="form-control"
                                   defaultValue={product?.price}/>
                        </div>
                        <button type='submit' className="uk-button uk-button-primary">Valider</button>
                    </form>
                    <button className="uk-modal-close" type="button"></button>
                </div>
            </div>

        </div>, document.getElementById('modal'))
}

export default ProductForm;