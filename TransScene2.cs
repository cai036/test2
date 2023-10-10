using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //首先引入此命名空间

public class TransScene2 : MonoBehaviour
{
    //访问修饰符应该是公有的，让外部可以访问到
    public void test1()
    {
        SceneManager.LoadScene("test1");  //引号中是你要切换的场景名字
    }
     public void test1wrong()
    {
        SceneManager.LoadScene("test1wrong");  //引号中是你要切换的场景名字
    }
    public void test1correct()
    {
        SceneManager.LoadScene("test1correct");  //引号中是你要切换的场景名字
    }
    public void test2correct()
    {
        SceneManager.LoadScene("test2correct");  //引号中是你要切换的场景名字
    }
    public void test2wrong()
    {
        SceneManager.LoadScene("test2wrong");  //引号中是你要切换的场景名字
    }
    public void test2()
    {
        SceneManager.LoadScene("test2");  //引号中是你要切换的场景名字
    }
    public void test3correct()
    {
        SceneManager.LoadScene("test3correct");  //引号中是你要切换的场景名字
    }
    public void test3wrong()
    {
        SceneManager.LoadScene("test3wrong");  //引号中是你要切换的场景名字
    }
    public void test3()
    {
        SceneManager.LoadScene("test3");  //引号中是你要切换的场景名字
    }
}


