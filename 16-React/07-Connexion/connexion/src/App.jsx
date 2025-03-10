import './App.css'
import Form from './Components/Form'

function App() {

  const submitLogin = (formData) => {
    console.log(formData.get("username"));
    console.log(formData.get("password"));
  }

  return (
    <>
    <Form submitLogin={submitLogin}/>
    </>
  )
}

export default App
