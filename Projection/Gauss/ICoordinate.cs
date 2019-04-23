using System;
using System.Collections.Generic;
using System.Text;

namespace Projection.Gauss
{
    public interface ICoordinate
    {        
        /// <summary>
        /// ����
        /// </summary>
        int ZoneWide { get;set;}

        /// <summary>
        /// ʮ����˫���ȽǶ�ת���ɶȷ���Ƕȸ�ʽ
        /// </summary>
        /// <param name="Decimal Degree">�ȣ�ʮ������˫����</param>
        /// <param name="Degree">�ȣ�����</param>
        /// <param name="Minute">�֣�����</param>
        /// <param name="Second">�룬˫������</param>
        void DD2DMS(double DecimalDegree, out int Degree, out int Minute, out double Second);

        /// <summary>
        /// ������֮��ľ���(���ݾ�γ��)
        /// </summary>
        /// <param name="lng1">����1</param>
        /// <param name="lat1">γ��1</param>
        /// <param name="lng2">����2</param>
        /// <param name="lat2">γ��2</param>
        /// <param name="gs">��˹ͶӰ����ѡ�õĲο�����</param>
        /// <returns>��������(��λ:meters)</returns>
        double DistanceOfTwoPoints(double lng1, double lat1, double lng2, double lat2, Spheroid gs);

        /// <summary>
        /// ������֮��ľ���(�������)
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns>��λΪmeters</returns>
        //double DistanceOfTwoPoints(double x1, double y1, double x2, double y2);

        /// <summary>
        /// �ȷ���Ƕȸ�ʽת����ʮ���ƶ�˫���ȽǶȸ�ʽ
        /// </summary>
        /// <param name="Degree">�ȣ�����</param>
        /// <param name="Minute">�֣�����</param>
        /// <param name="Second">�룬˫������</param>
        /// <param name="Decimal Degree">�ȣ�ʮ������˫����</param>   
        void DMS2DD(int Degree, int Minute, double Second, out double DecimalDegree);

        /// <summary>
        /// ����ͶӰ����
        /// �ɾ�γ�ȣ���λ��Decimal Degree�����㵽������꣨��λ��Metre�������ţ�
        /// </summary>
        /// <param name="longitude">����</param>
        /// <param name="latitude">γ��</param>
        void GaussPrjCalculate(double longitude, double latitude,out double X,out double Y);

        /// <summary>
        /// ��˹ͶӰ����
        /// ������꣨��λ��Metre�������ţ����㵽��γ�����꣨��λ��Decimal Degree��
        /// </summary>
        /// <param name="X">�������Xֵ</param>
        /// <param name="Y">�������Yֵ</param>
        void GaussPrjInvCalculate(double X, double Y,out double longitude,out double latitude);

    }
}
