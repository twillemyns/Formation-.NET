import { useState } from 'react'
import './App.css'

function App() {

  const [number, setNumber] = useState(0);

  const augmenterValeur = () => {
    setNumber(n => n + 1)
  }

  const diminuerValeur = () => {
    setNumber(n => n - 1)
  }

  const render = () => {
    if(number % 15 == 0){
      return "Fizzbuzz"
    }else if (number % 5 == 0) {
      return "Buzz"
    }else if (number % 3 == 0) {
      return "Fizz"
    }else {
      return number
    }
  }

  return (
    <>
      <h1>FizzBuzz</h1>
      <p>{render()}</p>

      <button onClick={diminuerValeur} disabled={number === 0}>Diminuer la valeur</button>
      <button onClick={augmenterValeur} disabled={number === 100}>Augmenter la valeur</button>
    </>
  )
}

export default App
