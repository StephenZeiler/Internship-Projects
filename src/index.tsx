import ReactDOM from 'react-dom/client';
import React, { useState } from 'react';
import { render } from '@testing-library/react';
import { createRoot } from 'react-dom/client';
import { Component } from 'react';

type turn = { player: String }
const SQUARE = (props: {
  current: turn
}) => {
  return (
    <button onClick={() => { }}>{props.current.player}</button>

  );
}

const Square = (props: { player: string }) => {
  return (
    <button onClick={() => { }}>{props.player}</button>
  )
}

function Board() {
 const [turn, setTurn] = React.useState<boolean>(false)
// setTurn(!turn)
  return (
  <div>
    <div>
      <Square player='X' /> <Square player='X' /> <Square player='X' />
    </div>
    <div>
      <Square player='X' /> <Square player='X' /> <Square player='X' />
    </div>
    <div>
      <Square player='X' /> <Square player='X' /> <Square player='X' />
    </div>
  </div>
 );
}
function Game() {

}

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
const element = <Board />
root.render(element);



