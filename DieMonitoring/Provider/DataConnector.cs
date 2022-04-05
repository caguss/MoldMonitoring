using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DataTable mornitoring_AlarmList_R10(string checkYN)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_mornitoring_AlarmList_R10",
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
                    return new DataTable();
                }
            }
        }

        /// <summary>
        /// 알람 삭제 프로시져. 삭제한 로그는 history_log로 이동
        /// </summary>
        /// <param name="checkYN"></param>
        /// <returns></returns>
        public void mornitoring_AlarmList_D10(string seq)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_mornitoring_AlarmList_D10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_seq", MySqlDbType.Int16));
                    cmd.Parameters["@v_seq"].Value = seq;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                }
            }
        }

        /// <summary>
        /// 알람 체크 프로시져. checkYN만 변경
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public void mornitoring_AlarmList_U10(string seq)
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_mornitoring_AlarmList_U10",
                        CommandType = CommandType.StoredProcedure,
                        Connection = conn
                    };
                    cmd.Parameters.Add(new MySqlParameter("@v_seq", MySqlDbType.Int16));
                    cmd.Parameters["@v_seq"].Value = seq;
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                }
            }
        }
        #endregion
        #region 태그데이터
        /// <summary>
        /// MainMonitoring Form에서 현재 태그데이터 불러오기
        /// </summary>
        /// <returns></returns>
        public DataSet monitoring_sensor_R10()
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
        #endregion
        #region 그래프관련
        public DataTable mornitoring_Graph_R10()
        {
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_mornitoring_Graph_R10",
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
                    return new DataTable();
                }
            }
        }
        #endregion
        #region 금형이름 관련
        public Dictionary<string,string> mornitoring_MoldList_R10()
        {
            // errorcode 테이블도 조인해야함.
            using (MySqlConnection conn = new MySqlConnection(StringConnection))
            {
                Dictionary<string, string> result = new Dictionary<string, string>();

                conn.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand
                    {
                        CommandText = "USP_mornitoring_MoldList_R10",
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
                        result.Add("knowingerr","오류! 금형이름이 등록되어 있지 않습니다.");
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    result.Add("exerr",ex.Message);
                    return result;
                }
            }
        }
        #endregion
    }
}
