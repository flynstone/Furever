import React, { useState } from 'react';
import Animal from '../Animal';
import AnimalPopUp from '../AnimalPopUp';

const ANIMALS = [
  {
    IMG: 'IMAGE',
    name: 'Animal #1',
    age: '3',
    breed: 'cat'
  }
  

]

const Home = ({ name }) => {
  const [selectedAnimal, setSelectedAnimal] = useState(null);

  return (
    <div>
      <h1>Find your Soulmate</h1>
      {ANIMALS.map(animal => (
        <Animal animal={animal} setSelectedAnimal={setSelectedAnimal} />
      ))}
      {/* {selectedAnimal !== null (
        <AnimalPopUp animal={selectedAnimal} setSelectedAnimal={setSelectedAnimal} />
      )} */}
    </div>
  );
}

export default Home;
