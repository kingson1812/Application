using System.Text;
using Global;
using System;
using System.Xml;

namespace Function
{
    namespace IO
    {
        public class File
        {
            public File()
            {
                //Just init
            }

            public File(string str)
            {
                m_filePath = str;
            }

            public void Read()
            {
                try
                {
                    XmlDocument xdoc=new XmlDocument();
                    xdoc.Load(m_filePath);
                    if (xdoc == null)
                        Log.ERROR("Cant load xml file {0}", m_filePath);
                    XmlNode root = xdoc.FirstChild;

                    //Node AlgorithmTitle
                    XmlNode alTitle = root["AlgorithmTitle"];
                    for(int i=0;i<alTitle.ChildNodes.Count;i++)
                    {
                        DictionaryStructure tmpDic = new DictionaryStructure(Key.g_name[0], alTitle.ChildNodes[i].InnerText);
                        UIContent.GetInstance().UpdateDataTable(tmpDic);
                    }

                    //Node AlgorithmContent
                    XmlNodeList alContent = root.SelectNodes("AlgorithmContent");
                    if (alContent.Count == 0)
                        Log.ERROR("Cant find any nodes like AlgorithmContent");
                    else
                    {
                        for (int i = 0; i < alContent.Count; i++)
                        {
                            for (int j = 0; j < alContent[i].ChildNodes.Count; j++)
                            {
                                string key = (alContent[i].Attributes["id"].Value.ToLower() == "sort") ? Key.g_name[1] : Key.g_name[2];
                                DictionaryStructure tmpDic = new DictionaryStructure(key, alContent[i].ChildNodes[j].InnerText);
                                UIContent.GetInstance().UpdateDataTable(tmpDic);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.ERROR(ex.ToString());
                }
            }

            private string m_filePath;
        }
    }
}
