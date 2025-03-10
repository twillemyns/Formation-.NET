const Table = ({ person }) => {

    const showTable = () => {
        console.log(person);

    }

    return (
        <>
            <button onClick={showTable}>Voir table</button>
            <table className="table" >
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Prénom</th>
                        <th>Nom</th>
                    </tr>
                </thead>
                <tbody key={person.id}>
                    {
                        person.length === 0 ?
                            <tr>
                                <td colSpan="3"><i>Pas de contact</i></td>
                            </tr>
                            :
                            person.map((p) => (
                                <tr>
                                    <td>{p.Id}</td>
                                    <td>{p.Firstname}</td>
                                    <td>{p.Lastname}</td>
                                </tr>
                            ))
                    }
                </tbody>
            </table>
        </>
    )
}

export default Table