import React from 'react';


const Animal = ({ animal, setSelectedAnimal }) => {

  
  return (
    <div onClick={() => setSelectedAnimal(animal)}>
      <div>{animal.IMG}</div>
      <div>{animal.Name}</div>
      <div>{animal.Age}</div>
      <div>{animal.Breed}</div>
    </div>
  ) 
  // populate that with name, age, breed, img form json of api call
}

export default Animal;