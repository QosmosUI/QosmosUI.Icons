// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiAlarmOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Alarm_Off");
		builder.AddAttribute(15, "data-name", "Alarm Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M4.564,3.856a.5.5,0,0,0-.7.71l.29.29-.5.5a2.019,2.019,0,0,0-.01,2.85l.65.67a8.273,8.273,0,0,0-.71,3.39A8.427,8.427,0,0,0,12,20.686a8.275,8.275,0,0,0,5.72-2.26c.57.57,1.14,1.15,1.71,1.71a.5.5,0,0,0,.71-.7Zm-.21,2.21.51-.5c.32.33.65.65.98.98a6.38,6.38,0,0,0-1.06,1.4l-.43-.44A1.032,1.032,0,0,1,4.354,6.066ZM12,19.686a7.43,7.43,0,0,1-7.42-7.42,7.312,7.312,0,0,1,1.96-5.02l2.59,2.59q3.945,3.945,7.88,7.88A7.27,7.27,0,0,1,12,19.686Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20.354,8.216a2.04,2.04,0,0,0,0-2.86l-1.46-1.45a2.01,2.01,0,0,0-2.85,0l-.68.67a8.528,8.528,0,0,0-6.38-.17c-.6.23-.34,1.19.27.97a7.419,7.419,0,0,1,9.64,9.64c-.22.6.74.86.97.26a8.506,8.506,0,0,0-.17-6.39Zm-2.4-1.9a8.068,8.068,0,0,0-1.65-1.27l.44-.43a1.026,1.026,0,0,1,1.45,0l1.45,1.45a1.014,1.014,0,0,1,0,1.44l-.43.44A8.262,8.262,0,0,0,17.954,6.316Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
