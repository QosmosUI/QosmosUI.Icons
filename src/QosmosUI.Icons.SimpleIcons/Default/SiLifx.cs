// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiLifx : ComponentBase
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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M3.128 8.2a3.11 3.11 0 0 0-2.212.92A3.148 3.148 0 0 0 0 11.347a3.144 3.144 0 0 0 .916 2.226l.27.266.014-.014a2.729 2.729 0 0 1 1.932-.795 2.739 2.739 0 0 1 1.931.795l.015.014.266-.27a3.157 3.157 0 0 0 .916-2.226c0-.806-.305-1.612-.916-2.226A3.139 3.139 0 0 0 3.128 8.2zm0 .725a2.39 2.39 0 0 1 1.701.707 2.431 2.431 0 0 1 .156 3.252 3.42 3.42 0 0 0-3.72 0 2.45 2.45 0 0 1-.544-1.537c0-.618.234-1.24.706-1.715a2.38 2.38 0 0 1 1.701-.707zm5.316.082v6.025h3.167v-1.487H9.928l.004-4.538zm4.247 0v6.022h1.487V9.007zm2.585 0v6.025h1.487V13.15h1.918v-1.41h-1.918v-1.228h3.047l.863 1.545-1.662 2.975h1.662l.813-1.53.696 1.53h1.779l-1.665-2.975L24 9.007h-1.779l-.735 1.686-.735-1.686zM3.128 13.75c-.518 0-1.04.202-1.438.6l.444.443a1.41 1.41 0 0 1 1.996 0l.443-.443c-.4-.398-.92-.6-1.445-.6zm0 1.324a.707.707 0 0 0-.507.213l.507.511.508-.511a.701.701 0 0 0-.508-.213Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
