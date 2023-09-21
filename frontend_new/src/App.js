import React from 'react';
import './App.css';

function App() {
  const [number1,setNumber1] = React.useState();
  const [number2,setNumber2] = React.useState();
  const [total,setTotal] = React.useState(0);
  const handleClick = async()=>{
    fetch('https://localhost:44341/Add',{
      method:'POST',
      body:JSON.stringify({
        Integer1:number1,
        Integer2:number2
      }),
      headers: {
        'Content-type': 'application/json; charset=UTF-8',
     },
    }).then((response) => response.json())
    .then((data)=>setTotal(data))
    .catch((err)=>console.log(err))
  };
  return (
    <div >
     <input
      value={number1}
      type='number'
      placeholder='First Number'
      onChange={(e)=>setNumber1(+e.target.value)}
     />
     <input
      value={number2}
      type='number'
      placeholder='Second Number'
      onChange={(e)=>setNumber2(+e.target.value)}
     />
     <button onClick={handleClick}>Sum</button>
     <p>Total :{total}</p>
    </div>
  );
}

export default App;
