import {useSelector} from 'react-redux';
import ProductItem from "./ProductItem.jsx";
import {useState} from "react";
import ProductForm from "./ProductForm.jsx";

const ProductList = () => {

    const [ModalIsOpen, setModalIsOpen] = useState(false);

    const products = useSelector((state) => state.product.products);

    const displayModal = () => {
        setModalIsOpen(!ModalIsOpen);
    }

    return (
        <>
            <table className="uk-table uk-table-striped">
                <thead>
                <tr>
                    <th>Nom</th>
                    <th>Prix</th>
                    <th colSpan={2} className={"uk-table-expand"}>Actions</th>
                </tr>
                </thead>
                <tbody>
                {products.map((product) => (
                    <ProductItem product={product} key={product.id}/>
                ))}
                </tbody>
            </table>

            <button type="button" className="uk-button uk-button-primary" onClick={() => displayModal()}>
                Ajouter un produit
            </button>
            <ProductForm/>
        </>
    );
};

export default ProductList;