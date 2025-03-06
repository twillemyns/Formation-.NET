const Table = () => {

    const person = [
        {
            Id: 1,
            firstname: "Albert",
            lastname: "DUPONT"
        },
        {
            Id: 2,
            firstname: "Maria",
            lastname: "DUPONT"
        },
        {
            Id: 3,
            firstname: "Chloé",
            lastname: "DUPONT"
        },
        {
            Id: 4,
            firstname: "Silvia",
            lastname: "MARTEZ"
        }
    ]

    return (
        <>
            <table className="table table-dark">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Prénom</th>
                        <th>Nom</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        person.map(p => (
                            <tr>
                                <td>{p.Id}</td>
                                <td>{p.firstname}</td>
                                <td>{p.lastname}</td>
                            </tr>
                        ))
                    }
                </tbody>
            </table>
        </>
    )
}

export default Table