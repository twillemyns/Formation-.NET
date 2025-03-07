import { useState } from "react";

const Form = ({addNewPerson}) => {

    let [id, setId] = useState();
    let [firstname, setFirstname] = useState();
    let [lastname, setLastname] = useState();

    const validate = () => {
        let newPerson = {
            Id: id,
            Firstname: firstname,
            Lastname: lastname
        }

        addNewPerson(newPerson);
    }

    return (
    <>
    <label htmlFor="id">Id:</label>
    <input type="text" id="id" onInput={(e) => setId(e.target.value)}/>
    <label htmlFor="firstname">Prénom:</label>
    <input type="text" id="firstname" onInput={(e) => setFirstname(e.target.value)}/>
    <label htmlFor="lastname">Nom de famille:</label>
    <input type="text" id="lastname" onInput={(e) => setLastname(e.target.value)}/>
    <button onClick={validate}>Ajouter un contact</button>
    </>
    );
}
 
export default Form;