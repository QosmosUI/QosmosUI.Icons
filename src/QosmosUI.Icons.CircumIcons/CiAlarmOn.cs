// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiAlarmOn : ComponentBase
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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Alarm_On");
		builder.AddAttribute(15, "data-name", "Alarm On");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.352,8.213a2.017,2.017,0,0,0,0-2.851L18.9,3.9a2.038,2.038,0,0,0-2.86,0l-.67.659A8.238,8.238,0,0,0,12,3.852a8.332,8.332,0,0,0-3.39.71L7.962,3.9a2.038,2.038,0,0,0-2.86,0L3.652,5.362a2.02,2.02,0,0,0-.01,2.851l.65.67a8.419,8.419,0,1,0,16.13,3.39,8.4,8.4,0,0,0-.72-3.411ZM4.362,6.062l1.45-1.45a1.016,1.016,0,0,1,1.44,0l.44.43a8.427,8.427,0,0,0-2.91,2.9l-.42-.43A1.027,1.027,0,0,1,4.362,6.062ZM12,19.682a7.415,7.415,0,1,1,7.42-7.409A7.421,7.421,0,0,1,12,19.682Zm7.22-11.75a8.578,8.578,0,0,0-2.91-2.89l.44-.43a1.016,1.016,0,0,1,1.44,0l1.45,1.45a1.027,1.027,0,0,1,0,1.451Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M17.042,12.763H12a.455.455,0,0,1-.27-.081c-.03-.02-.05-.039-.07-.049a.442.442,0,0,1-.16-.36V7.232a.5.5,0,0,1,1,0v4.531h4.54A.5.5,0,0,1,17.042,12.763Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
