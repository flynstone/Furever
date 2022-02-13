import React from 'react';


const AnimalPopUp = ({animal, setSelectedAnimal}) => {
  
  return (
    <div>
      <button onClick={() => setSelectedAnimal(null)}>X button</button>
      <div>{animal.Refuge}</div>
      <div>{animal.img}</div>
      <div>{animal.name}</div>
      <div>{animal.age}</div>
      <div>{animal.breed}</div>
      <div>{animal.info}</div>
      <button>Like Button</button>
      <button>Ask more info Button</button>
    </div>
  ) 
  // Once animal is clicked, the pop up fills the page and displays more info as well as the liked component and the ask more info button
}

export default AnimalPopUp;