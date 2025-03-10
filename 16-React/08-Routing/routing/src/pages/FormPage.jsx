import { useLayoutEffect } from "react";
import { useState } from "react";
import { useParams, useSearchParams } from "react-router-dom";
import Table from "../components/Table";

const FormPage = () => {
    const { id } = useParams();
    const [user, setUser] = useState();
    const [mode, setMode] = useState();
    const [SearchParams] = useSearchParams();

    const users = [
        {
            id: 1,
            lastname: "TOTO",
            firstname: "Toto",
            email: "toto@email.fr",
            phone: "0101010101"
        },
        {
            id: 2,
            lastname: "TATA",
            firstname: "Tata",
            email: "tata@email.fr",
            phone: "0202020202"
        },
        {
            id: 3,
            lastname: "TITI",
            firstname: "Titi",
            email: "titi@email.fr",
            phone: "0303030303"
        },
    ]

    useLayoutEffect(() => {
        let formUser = users.find(u => u.id == id);
        let mode = SearchParams?.get("mode");
        setUser(formUser);
        setMode(mode);
    }, [])

    const formAction = (formData) => {
        if (user == null) {
            let newUser = {
                id: Math.max(...users.map(u => u.id)) + 1,
                lastname: formData.get("lastname"),
                firstname: formData.get("firstname"),
                email: formData.get("email"),
                phone: formData.get("phone")
            };
            users.push(newUser);
        } else if (mode == "update") {
            console.log(user);
            console.log(users);

            let index = users.findIndex(u => u.id == id);
            console.log(index);

            users[index] = {
                id: user.id,
                lastname: formData.get("lastname"),
                firstname: formData.get("firstname"),
                email: formData.get("email"),
                phone: formData.get("phone")
            }
        } else if (mode == "delete") {
            let index = users.findIndex(u => u.id == id);
            if (index == -1) return;
            users.splice(index, 1);
        }
    }

    return (
        <>
            <Table person={users} />

            <form action={formAction}>
                <div>
                    <label htmlFor="lastname" >Nom de famille:</label>
                    <input type="text" name="lastname" defaultValue={user?.lastname}/>
                </div>
                <div>
                    <label htmlFor="firstname" >Prénom:</label>
                    <input type="text" name="firstname" defaultValue={user?.firstname}/>
                </div>
                <div>
                    <label htmlFor="email" >Adresse mail:</label>
                    <input type="text" name="email" defaultValue={user?.email}/>
                </div>
                <div>
                    <label htmlFor="phone" >Numéro de téléphone:</label>
                    <input type="text" name="phone" defaultValue={user?.phone}/>
                </div>
                <button type="submit">Valider</button>
            </form>
        </>
    );
}

export default FormPage;