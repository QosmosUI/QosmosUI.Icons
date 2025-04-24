// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaBuffer : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 16 5 C 15.844 5 15.687922 5.0298438 15.544922 5.0898438 L 3.1953125 10.785156 C 2.9353125 10.905156 2.9353125 11.092891 3.1953125 11.212891 L 15.544922 16.910156 C 15.687922 16.970156 15.844 17 16 17 C 16.156 17 16.312078 16.970156 16.455078 16.910156 L 28.804688 11.212891 C 29.064688 11.092891 29.064687 10.905156 28.804688 10.785156 L 16.455078 5.0898438 C 16.312078 5.0298438 16.156 5 16 5 z M 16 7.0820312 L 24.492188 11 L 16 14.917969 L 7.5078125 11 L 16 7.0820312 z M 4.8398438 14.447266 L 3.1953125 15.269531 C 2.9353125 15.399531 2.9353125 15.600469 3.1953125 15.730469 L 15.544922 21.902344 C 15.687922 21.967344 15.844 22 16 22 C 16.156 22 16.312078 21.967344 16.455078 21.902344 L 28.804688 15.730469 C 29.064688 15.600469 29.064687 15.399531 28.804688 15.269531 L 27.160156 14.447266 L 16.455078 19.796875 C 16.312078 19.861875 16.156 19.894531 16 19.894531 C 15.844 19.894531 15.687922 19.861875 15.544922 19.796875 L 4.8398438 14.447266 z M 4.8398438 19.447266 L 3.1953125 20.269531 C 2.9353125 20.399531 2.9353125 20.600469 3.1953125 20.730469 L 15.544922 26.902344 C 15.687922 26.967344 15.844 27 16 27 C 16.156 27 16.312078 26.967344 16.455078 26.902344 L 28.804688 20.730469 C 29.064688 20.600469 29.064687 20.399531 28.804688 20.269531 L 27.160156 19.447266 L 16.455078 24.796875 C 16.312078 24.861875 16.156 24.894531 16 24.894531 C 15.844 24.894531 15.687922 24.861875 15.544922 24.796875 L 4.8398438 19.447266 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
