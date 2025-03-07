import { useState } from 'react';
import './App.css'

function App() {

  let [prenom, setPrenom] = useState();
  let [nom, setNom] = useState();

  const changePrenom = (e) => {
    setPrenom(e.target.value);
  }

  const changeNom = (e) => {
    setNom(e.target.value.toUpperCase());
  }

  return (
    <>
      <p><b>Bonjour, {prenom} {nom}. Bienvenue sur l'application!</b></p>

      <input type="text" onInput={changePrenom} />
      <input type="text" onInput={changeNom} />
    </>
  )
}

export default App
