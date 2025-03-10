import { useRef } from "react";

const Form = ({submitLogin}) => {

    return ( 
        <>
        <form action={submitLogin}>
        <div>
                <label htmlFor="username">Nom d'utilisateur</label>
                <input type="text" name='username'/>
                </div>
                <div>
                <label htmlFor="password">Mot de passe</label>
                <input type="password" name='password'/>
                </div>
                <button type='submit'>Valider</button>
        </form>
        </>
     );
}
 
export default Form;