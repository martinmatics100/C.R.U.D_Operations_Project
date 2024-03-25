import React, { useState } from "react";
import "bootstrap/dist/css/bootstrap.min.css";

const AddStudentModal = ({ onAdd }) => {
  const [firstName, setFirstName] = useState("");
  const [lastName, setLastName] = useState("");
  const [department, setDepartment] = useState("");
  const [gender, setGender] = useState(0);
  const [dateOfBirth, setDateOfBirth] = useState("");
  const [isGraduated, setIsGraduated] = useState(false); // New state for isGraduated

  const handleSubmit = () => {
    // Assuming basic validation is done here
    const newStudent = {
      firstName: firstName,
      lastName: lastName,
      department: department,
      gender: gender,
      dateOfBirth: dateOfBirth,
      isGraduated: isGraduated, // Include isGraduated in the new student object
      // Add more fields if necessary
    };
    onAdd(newStudent);
    // Clear input fields after adding the student
    setFirstName("");
    setLastName("");
    setDepartment("");
    setGender(0);
    setDateOfBirth("");
    setIsGraduated(false); // Reset isGraduated state after adding the student
  };

  return (
    <div
      className="modal fade"
      id="addStudentModal"
      tabIndex="-1"
      role="dialog"
      aria-labelledby="addStudentModalLabel"
      aria-hidden="true"
    >
      <div className="modal-dialog" role="document">
        <div className="modal-content">
          <div className="modal-header">
            <h5 className="modal-title" id="addStudentModalLabel">
              Add Student
            </h5>
            <button
              type="button"
              className="close"
              data-dismiss="modal"
              aria-label="Close"
            >
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div className="modal-body">
            <form>
              {/* Existing form fields */}
              <div className="form-group form-check">
                <input
                  type="checkbox"
                  className="form-check-input"
                  id="isGraduated"
                  checked={isGraduated}
                  onChange={(e) => setIsGraduated(e.target.checked)}
                />
                <label className="form-check-label" htmlFor="isGraduated">
                  Is Graduated
                </label>
              </div>
            </form>
          </div>
          <div className="modal-footer">
            <button
              type="button"
              className="btn btn-secondary"
              data-dismiss="modal"
            >
              Close
            </button>
            <button
              type="button"
              className="btn btn-primary"
              onClick={handleSubmit}
            >
              Add Student
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default AddStudentModal;
