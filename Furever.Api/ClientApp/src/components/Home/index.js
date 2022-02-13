import React, { useState } from 'react';
import Animal from '../Animal';
import AnimalPopUp from '../AnimalPopUp';
import "./Home.css"


const ANIMALS = [
  {
    IMG: 'IMAGE',
    name: 'Animal #1',
    age: '3',
    breed: 'cat'
  },
  {
    IMG: 'IMAGE',
    name: 'Animal #2',
    age: '6',
    breed: 'dog'
  },
  
  {
    IMG: 'IMAGE',
    name: 'Animal #3',
    age: '7',
    breed: 'dog'
  },

  {
    IMG: 'IMAGE',
    name: 'Animal #4',
    age: '1',
    breed: 'cat'
  },

  {
    IMG: 'IMAGE',
    name: 'Animal #5',
    age: '10',
    breed: 'cat'
  },

  {
    IMG: 'IMAGE',
    name: 'Animal #6',
    age: '8',
    breed: 'dog'
  },

  {
    IMG: 'IMAGE',
    name: 'Animal #7',
    age: '12',
    breed: 'dog'
  }

]

const Home = ({ name }) => {
  const [selectedAnimal, setSelectedAnimal] = useState(null);

  return (
    <div>
      <h1 className='Slogan'>Find your Soulmate</h1>
      <div className='AnimalTiles'>
        {ANIMALS.map(animal => (
          <Animal animal={animal} setSelectedAnimal={setSelectedAnimal} />
        ))}
      </div>
      {/* {selectedAnimal !== null (
        <AnimalPopUp animal={selectedAnimal} setSelectedAnimal={setSelectedAnimal} />
      )} */}
    </div>
  );
}

export default Home;
