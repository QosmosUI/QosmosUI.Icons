// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons.Default;

public class DiBrackets : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
		builder.AddAttribute(14, "d", "M24.995 5.975h-17.891c-1.212 0-2.218 1.223-2.409 2.826v1.107c0.004 0.037 0.009 0.074 0.014 0.111-0.006 0.026-0.010 0.053-0.014 0.080v13.989c0.279 1.444 1.229 2.507 2.36 2.507h17.891c1.131 0 2.082-1.063 2.36-2.507v-15.831c-0.329-1.328-1.239-2.284-2.31-2.284zM25.117 22.579c-0.224 1.165-0.991 2.022-1.903 2.022h-14.428c-0.912 0-1.678-0.857-1.903-2.022v-11.282c0.004-0.022 0.006-0.044 0.011-0.065-0.004-0.030-0.008-0.059-0.011-0.089v-0.893c0.154-1.293 0.965-2.28 1.943-2.28h14.428c0.864 0 1.597 0.77 1.863 1.841v12.767zM8.889 16.286v6.117h6.365v-2.785h-3.581v-6.664h3.581v-2.785h-6.366v6.117zM16.746 11.561v1.392h3.581v6.664h-3.581v2.785h6.366v-12.234h-6.366v1.392z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
