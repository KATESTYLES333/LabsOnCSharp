#include <iostream>
#include <stack>
#include <vector>
#include <algorithm>
#include <cmath>

template <class Iterator>
bool is_valid_brackets(Iterator first, Iterator last)
{
    using value_type = typename std::remove_reference <decltype(*first)>::type;
    std::stack <value_type> st;
    for(; first != last; ++first)
    {
        if(*first == '(')
        {
            st.push(*first);
        }
        if(*first == ')')
        {
            if(st.empty() || st.top == ')')
            {
                return false;
                st.pop();
            }
            return st.size() == 0;
        }
    }
}

struct Generator //заполнение стека
{
    int m_start;
    int m_step;
    Generator (int step = 1, int start = 0):m_start(start), m_step(step){}

    int operator()()
    {
        m_start += m_step;
        return m_start;
    }
};

template <class InputIt, class Generator>
void generate1(InputIt first, InputIt last, Generator g)
{
    for(; first != last; ++first)
    {
        *first = g();
    }
}

struct Point
{
    int x;
    int y;
    Point() = default;
    Point(int x_, int y_)
    {
        x_ = x;
        y_ = y;
    }
};

int main()
{
    std::vector<int> a(100);
    generate1(a.begin(), a.end(), Generator(5,0));
    //сгенирировать последовательность и посчитать количество, сколько раз встречается
    int result = std::count_if(a.begin(), a.end(),[](int v){return v % 5 == 0;});
    std::stack<int> st;
    for(auto i = a.begin(); i != a.end(); ++i)
    {
        st.push(*i);
    }
    while (st.size())
    {
        int temp;
        if(st.top() % 5 == 0)
        {
            ++temp;
        }
        st.pop();
    }
    return 0;
}
