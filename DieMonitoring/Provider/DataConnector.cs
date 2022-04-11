using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieMonitoring
{
    public class DataConnector
    {
        static string StringConnection = $"Server={Program.ServerName},{Program.Port}; Database={Program.DatabaseName}; uid={Program.Uid}; pwd={Program.Pwd}";

        #region 알람관련

        /// <summary>
        /// checkYN을 통한 알람 리스트 가져오는 프로시져
        /// </summary>
        /// <param name="checkYN"></param>
        /// <returns></returns>
        public DataTable monitoring_AlarmList_R10(string checkYN)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_AlarmList_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_checkYN", MySqlDbType.VarChar, 1));
                    cmd.Parameters["@v_checkYN"].Value = checkYN;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                    return new DataTable();
                }
            }
        }

        /// <summary>
        /// 알람 삭제 프로시져. 삭제한 로그는 history_log로 이동
        /// </summary>
        /// <param name="checkYN"></param>
        /// <returns></returns>
        public void monitoring_AlarmList_D10(string seq)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_AlarmList_D10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_seq", MySqlDbType.Int16));
                    cmd.Parameters["@v_seq"].Value = seq;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                }
            }
        }


        /// <summary>
        /// 알람 체크 프로시져. checkYN만 변경
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public void monitoring_AlarmList_U10(string seq)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_AlarmList_U10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_seq", MySqlDbType.Int16));
                    cmd.Parameters["@v_seq"].Value = seq;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                }
            }
        }
        #endregion
        #region 센서관련
        /// <summary>
        /// MainMonitoring Form에서 현재 태그데이터 불러오기
        /// </summary>
        /// <returns></returns>
        public DataSet monitoring_sensor_R10(int maxcnt)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_sensor_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn

                    };

                    cmd.Parameters.Add(new MySqlParameter("@v_conncnt", MySqlDbType.Int32));
                    cmd.Parameters["@v_conncnt"].Value = maxcnt;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;

                }
                catch (Exception ex)
                {
                    return new DataSet();
                }
            }
        }
        public DataTable monitoring_sensor_R20()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StringConnection))
                {
                    conn.Open();
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand
                        {
                            CommandText = "USP_monitoring_sensor_R20",
                            CommandType = CommandType.StoredProcedure,
                            Connection = conn
                        };
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        return ds.Tables[0];

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                        return new DataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                return new DataTable();
            }

        }
        public DataTable monitoring_sensor_R30()
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_sensor_R30",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                    return new DataTable();
                }
            }
        }
        #endregion
        #region 그래프관련
        public DataTable monitoring_Graph_R10()
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_Graph_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                    return new DataTable();
                }
            }
        }

        public DataTable monitoring_summary_R10(string selectedgroup, string selectedsensor, int selectedtime)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_summary_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_selectedgroup", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@v_selectedsensor", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@v_selectedtime", MySqlDbType.Int32));
                    cmd.Parameters["@v_selectedgroup"].Value = selectedgroup;
                    cmd.Parameters["@v_selectedsensor"].Value = selectedsensor;
                    cmd.Parameters["@v_selectedtime"].Value = selectedtime;


                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                    return new DataTable();
                }
            }
        }

        public DataTable monitoring_summary_R20(int selectedtime)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_summary_R20",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_selectedtime", MySqlDbType.Int32));
                    cmd.Parameters["@v_selectedtime"].Value = selectedtime;


                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    else
                    {
                        return new DataTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                    return new DataTable();
                }
            }
        }
        #endregion
        #region 금형이름 관련
        public Dictionary<string, string> monitoring_MoldList_R10()
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                Dictionary<string, string> result = new Dictionary<string, string>();

                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_MoldList_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            result.Add(ds.Tables[0].Rows[i]["moldCode"].ToString(), ds.Tables[0].Rows[i]["moldName"].ToString());
                        }
                        return result;
                    }
                    else
                    {
                        result.Add("knowingerr", "오류! 금형이름이 등록되어 있지 않습니다.");
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    result.Add("exerr", ex.Message);
                    return result;
                }
            }
        }


        public void monitoring_MoldList_U10(string selectedMoldCode)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_MoldList_U10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_moldcode", MySqlDbType.VarChar, 10));
                    cmd.Parameters["@v_moldcode"].Value = selectedMoldCode;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                }
            }
        }
        #endregion
        #region 옵션 관련
        public DataSet monitoring_Setting_R10()
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_Setting_R10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();

                    return ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");

                    return new DataSet();
                }
            }
        }
        public DataTable monitoring_Setting_R20(string gr, string rsc)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_monitoring_Setting_R20",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_gr", MySqlDbType.VarChar, 50));
                    cmd.Parameters.Add(new MySqlParameter("@v_rsc", MySqlDbType.VarChar, 50));
                    cmd.Parameters["@v_gr"].Value = gr;
                    cmd.Parameters["@v_rsc"].Value = rsc;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    da.Fill(ds);
                    da.Dispose();
                    conn.Close();
                    return ds.Tables[0];

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"에러가 발생했습니다. 관리자에게 문의해 주세요. {ex.Message}");
                    return new DataTable();

                }
            }
        }
        public void monitoring_Setting_U10(string gr, string limit_high, string limit_low)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    CommandText = "USP_monitoring_Setting_U10",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conn
                };
                cmd.Parameters.Add(new MySqlParameter("@v_gr", MySqlDbType.VarChar, 50));
                cmd.Parameters.Add(new MySqlParameter("@v_limit_high", MySqlDbType.Decimal));
                cmd.Parameters.Add(new MySqlParameter("@v_limit_low", MySqlDbType.Decimal));
                cmd.Parameters["@v_gr"].Value = gr;
                cmd.Parameters["@v_limit_high"].Value = limit_high;
                cmd.Parameters["@v_limit_low"].Value = limit_low;

                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }

        public void monitoring_Setting_U20(string gr,string rsc, string limit_high, string limit_low)
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    CommandText = "USP_monitoring_Setting_U10",
                    CommandType = CommandType.StoredProcedure,
                    Connection = conn
                };
                cmd.Parameters.Add(new MySqlParameter("@v_gr", MySqlDbType.VarChar, 50));
                cmd.Parameters.Add(new MySqlParameter("@v_rsc", MySqlDbType.VarChar, 50));
                cmd.Parameters.Add(new MySqlParameter("@v_limit_high", MySqlDbType.Decimal));
                cmd.Parameters.Add(new MySqlParameter("@v_limit_low", MySqlDbType.Decimal));
                cmd.Parameters["@v_gr"].Value = gr;
                cmd.Parameters["@v_rsc"].Value = rsc;
                cmd.Parameters["@v_limit_high"].Value = limit_high;
                cmd.Parameters["@v_limit_low"].Value = limit_low;

                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }
        #endregion
    }
}
