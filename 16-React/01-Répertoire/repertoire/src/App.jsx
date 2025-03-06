import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import Table from './Components/Table'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <h1>Répertoire</h1>

      <Table/>
    </>
  )
}

export default App
