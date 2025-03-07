import { useEffect } from "react";
import { useState } from "react";

const Mult = (props) => {

    let [ope1, setOpe1] = useState(0);
    let [ope2, setOpe2] = useState(0);
    let [IsEqual, setIsEqual] = useState(false);

    useEffect(() => {
        setIsEqual(ope1 * ope2 == props.result);
    }, [ope1, ope2]);

    const changeOpe1 = (e) => {
        setOpe1(e.target.value);
    }

    const changeOpe2 = (e) => {
        setOpe2(e.target.value);
    }
    
    const result = () => {
        let expected = props.result;

        if (IsEqual) {
            return `La multiplication des 2 nombres fait bien ${expected}.`;
        }else {
            return `La multiplication des 2 nombres ne fait pas ${expected}.`;
        }
    }

    return (
        <><div>
            <input type="number" onInput={changeOpe1} />
            <input type="number" onInput={changeOpe2} />
        </div>

            <p>{result()}</p>
        </>
    );
}

export default Mult;