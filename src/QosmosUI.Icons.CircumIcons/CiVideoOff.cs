// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiVideoOff : ComponentBase
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
		builder.AddAttribute(14, "id", "Video_Off");
		builder.AddAttribute(15, "data-name", "Video Off");
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M20.783,9.51v6.53a.5.5,0,0,1-1,0V9.6c0-.85.06-1.72,0-2.57-.03-.37-.27-.5-.61-.3-.39.22-.76.51-1.13.76-.73.49-1.47.99-2.2,1.49,0,.71-.01,1.41-.01,2.11a.5.5,0,0,1-1,0V9.12c0-.58.01-1.16,0-1.74a1.524,1.524,0,0,0-1.56-1.5c-1.22-.01-2.43,0-3.65,0a.5.5,0,0,1,0-1h2.13c.6,0,1.22-.05,1.81.01a2.54,2.54,0,0,1,2.27,2.5c0,.13.01.26,0,.39.77-.53,1.55-1.05,2.32-1.57a2.466,2.466,0,0,1,1.26-.6,1.364,1.364,0,0,1,1.37,1.36C20.813,7.81,20.783,8.67,20.783,9.51Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M19.773,19.08q-6.5-6.51-12.99-13c-.62-.62-1.24-1.24-1.87-1.86-.45-.46-1.16.25-.7.71l.28.28A2.468,2.468,0,0,0,3.2,7.38v9.24a2.5,2.5,0,0,0,2.5,2.5h7.63a2.5,2.5,0,0,0,2.5-2.5v-.07l1.37,1.37c.62.62,1.24,1.24,1.87,1.86A.5.5,0,0,0,19.773,19.08Zm-4.94-2.46a1.5,1.5,0,0,1-1.5,1.5H5.7a1.5,1.5,0,0,1-1.5-1.5V7.38a1.5,1.5,0,0,1,1.04-1.42l9.59,9.59Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
