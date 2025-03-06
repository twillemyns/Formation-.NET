import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import Table from './Components/Table'

function App() {

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
  ];

  const addPerson = () => {
    person.push({
      Id: 99,
      firstname: "toto",
      lastname: "tata"
    });

    console.log(person);
  }

  return (
    <>
      <Table person={person} />

      <button onClick={(addPerson)}>Ajouter</button>
    </>
  )
}

export default App
