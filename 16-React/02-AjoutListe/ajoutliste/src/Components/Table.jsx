const Table = (props) => {

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
                        props.person.map(p => (
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