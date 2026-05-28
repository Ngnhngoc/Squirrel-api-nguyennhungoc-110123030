package com.squirrel;

public class EquationSolver {
    public String giaiPhuongTrinhBac1(double a, double b) {
        if (a == 0) {
            if (b == 0) {
                return "VSN"; // Vô số nghiệm
            } else {
                return "VN";  // Vô nghiệm
            }
        } else {
            return "CN";      // Có nghiệm
        }
    }
}