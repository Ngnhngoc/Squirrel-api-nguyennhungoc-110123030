package com.squirrel;

import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class EquationSolverTest {
    EquationSolver solver = new EquationSolver();

    @Test
    public void testVoSoNghiem() {
        // Trường hợp a = 0, b = 0 -> Kỳ vọng kết quả trả về là "VSN"
        assertEquals("VSN", solver.giaiPhuongTrinhBac1(0, 0));
    }

    @Test
    public void testVoNghiem() {
        // Trường hợp a = 0, b != 0 -> Kỳ vọng kết quả trả về là "VN"
        assertEquals("VN", solver.giaiPhuongTrinhBac1(0, 5));
    }

    @Test
    public void testCoNghiem() {
        // Trường hợp a != 0 -> Kỳ vọng kết quả trả về là "CN"
        assertEquals("CN", solver.giaiPhuongTrinhBac1(2, -4));
    }
}