import React, { useState } from "react";

const AddStudentForm = ({ onAddStudent }) => {
  const [newStudent, setNewStudent] = useState({
    firstName: "",
    lastName: "",
    department: "",
    gender: "",
    dateOfBirth: "",
    age: "",
    isGraduated: false,
  });

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setNewStudent({
      ...newStudent,
      [name]: value,
    });
  };

  const handleAddStudent = () => {
    // Validate student details
    if (
      newStudent.firstName &&
      newStudent.lastName &&
      newStudent.department &&
      newStudent.gender &&
      newStudent.dateOfBirth &&
      newStudent.age
    ) {
      // Call the onAddStudent callback function and pass the new student object
      onAddStudent(newStudent);
      // Reset input fields
      setNewStudent({
        firstName: "",
        lastName: "",
        department: "",
        gender: "",
        dateOfBirth: "",
        age: "",
        isGraduated: false,
      });
    } else {
      alert("Please fill in all fields");
    }
  };

  return (
    <div>
      <h2>Add Student</h2>
      <div>
        <label>First Name:</label>
        <input
          type="text"
          name="firstName"
          value={newStudent.firstName}
          onChange={handleInputChange}
        />
      </div>
      <div>
        <label>Last Name:</label>
        <input
          type="text"
          name="lastName"
          value={newStudent.lastName}
          onChange={handleInputChange}
        />
      </div>
      <div>
        <label>Department:</label>
        <input
          type="text"
          name="department"
          value={newStudent.department}
          onChange={handleInputChange}
        />
      </div>
      <div>
        <label>Gender:</label>
        <select
          name="gender"
          value={newStudent.gender}
          onChange={handleInputChange}
        >
          <option value="">Select Gender</option>
          <option value="0">Male</option>
          <option value="1">Female</option>
        </select>
      </div>
      <div>
        <label>Date of Birth:</label>
        <input
          type="date"
          name="dateOfBirth"
          value={newStudent.dateOfBirth}
          onChange={handleInputChange}
        />
      </div>
      <div>
        <label>Age:</label>
        <input
          type="number"
          name="age"
          value={newStudent.age}
          onChange={handleInputChange}
        />
      </div>
      <div>
        <label>
          <input
            type="checkbox"
            name="isGraduated"
            checked={newStudent.isGraduated}
            onChange={() =>
              setNewStudent({
                ...newStudent,
                isGraduated: !newStudent.isGraduated,
              })
            }
          />{" "}
          Graduated
        </label>
      </div>
      <button onClick={handleAddStudent}>Add Student</button>
    </div>
  );
};

export default AddStudentForm;
