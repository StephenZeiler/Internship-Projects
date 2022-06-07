import ReactDOM from 'react-dom/client';
import React, { useState } from 'react';
import { render } from '@testing-library/react';
import { createRoot } from 'react-dom/client';
import { Component } from 'react';

function Square(){
  var value = false;
  const [count, setCount] = useState(0);
  console.log(1)
  return(
    
    <button> 
    </button>
  

  );

}

function Board(){

}

function Game(){
  return(
<Square></Square>
  );
}

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
const element = <Game />
root.render(element);



