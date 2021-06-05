﻿using EJournalDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using EJournalDAL.Models.BaseModels;
using System.Threading.Tasks;
using EJournalBLL.Models;

namespace EJournalBLL
{
    public class StudentService
    {
        string connection;
        StudentsRepository studentsRepository;

        public StudentService(string connection)
        {
            this.connection = connection;
            studentsRepository = new StudentsRepository(connection);
        }

        public List<Student> GetAllStudent()
        {
            List<StudentDTO> studentDTO = studentsRepository.GetAll();
            List<Student> student = ObjectMapper.Mapper.Map<List<Student>>(studentDTO);
            return student;
        }
        public void AddStudent(Student studentInput)
        {
            StudentDTO student = ObjectMapper.Mapper.Map<StudentDTO>(studentInput);
            studentsRepository.Create(student);
        }
        public void Update(Student studentInput)
        {
            StudentDTO student = ObjectMapper.Mapper.Map<StudentDTO>(studentInput);
            studentsRepository.Update(student);
        }

        public void Delete(int Id)
        {
            studentsRepository.DeleteSoft(Id);
        }
        public List<Student> GetStudentsFromProjectGroups(int IdProjectGroup)
        {
            List<StudentDTO> StudentsDTO = studentsRepository.GetStudentsFromOneProjectGroup(IdProjectGroup);
            List<Student> students = ObjectMapper.Mapper.Map<List<Student>>(StudentsDTO);
            return students;
        }
    }
}