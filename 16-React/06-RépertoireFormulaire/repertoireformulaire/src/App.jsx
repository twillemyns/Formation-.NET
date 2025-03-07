import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import Table from './Components/Table'
import Form from './Components/Form'
import { useState } from 'react'

function App() {

  let [person, setPerson] = useState([]);

  const addNewPerson = (newPerson) => {
    setPerson(p => [...p, newPerson]);
  }

  return (
    <>
      <Table person={person} />
      <hr />
      <Form addNewPerson={addNewPerson} />
    </>
  )
}

export default App
