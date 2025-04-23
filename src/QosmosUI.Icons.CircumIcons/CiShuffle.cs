// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiShuffle : ComponentBase
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
		builder.AddAttribute(14, "id", "Shuffle");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M21.794,17.082a.513.513,0,0,1,0,.71c-.08.08-.17.16-.25.25-.58.58-1.17,1.16-1.75,1.75a.5.5,0,0,1-.71-.71c.09-.08.17-.17.25-.25l.9-.9h-3.85a2.509,2.509,0,0,1-2.15-1.21L12,12.982l-2.24,3.74a2.509,2.509,0,0,1-2.15,1.21H2.564a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5h5.05A1.507,1.507,0,0,0,8.9,16.2l2.51-4.2L8.9,7.792a1.507,1.507,0,0,0-1.29-.73H2.564a.5.5,0,0,1,0-1h5.05a2.518,2.518,0,0,1,2.15,1.22L12,11.032l2.24-3.75a2.489,2.489,0,0,1,2.14-1.22h3.85l-1.15-1.15a.5.5,0,1,1,.71-.7c.08.08.17.16.25.25.58.58,1.17,1.16,1.75,1.75a.5.5,0,0,1,0,.7c-.08.09-.17.17-.25.25-.58.59-1.17,1.17-1.75,1.75a.5.5,0,1,1-.71-.7l.25-.25.9-.9h-3.85a1.519,1.519,0,0,0-1.29.73L12.584,12l2.51,4.2a1.519,1.519,0,0,0,1.29.73h3.84l-1.14-1.14a.5.5,0,0,1,.71-.71Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
