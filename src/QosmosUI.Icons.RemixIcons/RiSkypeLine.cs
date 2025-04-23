// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiSkypeLine : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M13.0052 18.4232C13.4288 18.3577 13.8623 18.43 14.2418 18.6295C14.7026 18.8719 15.2154 19 15.751 19C17.5459 19 19.001 17.5449 19.001 15.75C19.001 15.2144 18.8728 14.7016 18.6305 14.2408C18.431 13.8613 18.3586 13.4278 18.4242 13.0042C18.4752 12.6746 18.501 12.3393 18.501 12C18.501 8.41015 15.5908 5.5 12.001 5.5C11.6617 5.5 11.3264 5.52582 10.9968 5.57681C10.5731 5.64234 10.1396 5.57001 9.7602 5.37047C9.29939 5.12815 8.7866 5 8.25098 5C6.45605 5 5.00098 6.45507 5.00098 8.25C5.00098 8.78562 5.12912 9.29841 5.37145 9.75922C5.57098 10.1387 5.64332 10.5722 5.57778 10.9958C5.5268 11.3254 5.50098 11.6607 5.50098 12C5.50098 15.5899 8.41113 18.5 12.001 18.5C12.3403 18.5 12.6755 18.4742 13.0052 18.4232ZM12.001 20.5C7.30656 20.5 3.50098 16.6944 3.50098 12C3.50098 11.5545 3.53524 11.1171 3.60129 10.6901C3.21792 9.96108 3.00098 9.13087 3.00098 8.25C3.00098 5.35051 5.35148 3 8.25098 3C9.13185 3 9.96205 3.21694 10.6911 3.60031C11.118 3.53427 11.5555 3.5 12.001 3.5C16.6954 3.5 20.501 7.30558 20.501 12C20.501 12.4455 20.4667 12.8829 20.4007 13.3099C20.784 14.0389 21.001 14.8691 21.001 15.75C21.001 18.6495 18.6505 21 15.751 21C14.8701 21 14.0399 20.7831 13.3109 20.3997C12.8839 20.4657 12.4464 20.5 12.001 20.5ZM12.0539 16.9993C9.25237 16.9993 8.00098 15.6213 8.00098 14.5872C8.00098 14.0545 8.39165 13.6848 8.92925 13.6848C10.1291 13.6848 9.81574 15.4096 12.0539 15.4096C13.1967 15.4096 13.8297 14.7864 13.8297 14.1485C13.8297 13.7648 13.6423 13.3408 12.8868 13.1535L10.3965 12.5303C8.39095 12.0261 8.02674 10.9384 8.02674 9.91832C8.02674 7.7966 10.0191 7 11.8909 7C13.6117 7 15.6465 7.95606 15.6465 9.22756C15.6465 9.77348 15.1674 10.091 14.6347 10.091C13.6117 10.091 13.8004 8.67259 11.735 8.67259C10.712 8.67259 10.1389 9.13495 10.1389 9.79855C10.1389 10.4622 10.9418 10.6745 11.6409 10.834L13.4773 11.2427C15.4905 11.6947 16.001 12.8763 16.001 13.9891C16.001 15.7132 14.6765 17 12.0163 17L12.0539 16.9993Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
