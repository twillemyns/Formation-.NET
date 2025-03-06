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
            <table>
                <thead>
                    <th>#</th>
                    <th>Prénom</th>
                    <th>Nom</th>
                </thead>
                <tbody>
                    {person.forEach(p => {
                        <>
                            <td>{p.Id}</td>
                            <td>{p.firstname}</td>
                            <td>{p.lastname}</td>
                        </>
                    })
                    }
                </tbody>
            </table>
        </>
    )
}

export default Table