using QuizApp;

Question[] questions = new Question[]{
    new Question("What is the capital of Panama?",
    new string[]{"Panama", "David", "Chitre", "Los Santos"}, 
    0),
    new Question("What is the capital of Colombia?",
    new string[]{"Bogota", "Medellin", "Cali", "Cartagena"}, 
    0),
    new Question("What is the capital of Venezuela?",
    new string[]{"Caracas", "Maracay", "Valencia", "Barquisimeto"}, 
    0)
};

Quiz quiz = new Quiz(questions);

quiz.RunQuiz();

