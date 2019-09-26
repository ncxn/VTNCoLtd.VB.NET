Namespace BUS

    Public Class CurrentUserRole
        Private Shared _CurrentUserRoles As UserRoleCollection

        Public Shared Property RolesByUserName As UserRoleCollection
            Get
                Return _CurrentUserRoles
            End Get
            Set(ByVal value As UserRoleCollection)
                _CurrentUserRoles = value
            End Set
        End Property
    End Class

End Namespace