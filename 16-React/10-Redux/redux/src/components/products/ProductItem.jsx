import {useDispatch} from "react-redux";
import {removeProduct} from "./productSlice.js";
import {useState} from "react";
import ProductForm from "./ProductForm.jsx";

const ProductItem = ({product}) => {

    const [closeModal, setCloseModal] = useState(false);

    const displayModal = () => {
        setCloseModal(!closeModal)
    }

    const dispatch = useDispatch();

    return (
        <>
            <tr>
                <td>{product.name}</td>
                <td>{product.price}</td>
                <td>
                    <button uk-toggle="target: #form" type="button" className={"uk-button uk-button-primary"}>Modifier
                    </button>
                </td>
                <td>
                    <button className={"uk-button uk-button-danger"}
                            onClick={() => dispatch(removeProduct(product))}>Supprimer
                    </button>
                </td>
            </tr>

            <ProductForm product={product}/>
        </>
    )
}
export default ProductItem;