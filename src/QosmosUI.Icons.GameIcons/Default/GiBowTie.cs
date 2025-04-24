// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBowTie : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M51.855 169.203C31.677 191.101 21 223.381 21 256s10.677 64.9 30.855 86.797c15.674-.505 44.822-4.243 73.961-11.527 21.772-5.443 43.342-13.134 58.973-21.8-5.558-6.025-8.448-13.975-10.55-22.91a107.81 107.81 0 0 1-1.323-6.603l-58.443 16.697-4.946-17.308 61.588-17.596c-.068-1.912-.115-3.83-.115-5.75s.047-3.838.115-5.75l-61.588-17.596 4.946-17.308 58.443 16.697a107.81 107.81 0 0 1 1.322-6.604c2.103-8.934 4.993-16.884 10.551-22.91-15.631-8.665-37.2-16.356-58.973-21.799-29.14-7.284-58.287-11.022-73.96-11.527zm408.29 0c-15.674.505-44.822 4.243-73.961 11.527-21.772 5.443-43.342 13.134-58.973 21.8 5.558 6.025 8.448 13.975 10.55 22.91.505 2.14.94 4.35 1.323 6.603l58.443-16.697 4.946 17.308-61.588 17.596c.068 1.912.115 3.83.115 5.75s-.047 3.838-.115 5.75l61.588 17.596-4.946 17.308-58.443-16.697a107.81 107.81 0 0 1-1.322 6.604c-2.103 8.934-4.993 16.884-10.551 22.91 15.631 8.665 37.2 16.356 58.973 21.799 29.14 7.284 58.287 11.022 73.96 11.527C480.324 320.899 491 288.619 491 256s-10.677-64.9-30.855-86.797zM256 205c-13.571 0-27.173.992-37.957 2.867-10.784 1.876-18.862 5.678-19.68 6.496-1.878 1.879-4.809 7.578-6.601 15.198C189.969 237.18 189 246.6 189 256c0 9.4.969 18.82 2.762 26.44 1.792 7.619 4.723 13.318 6.601 15.197.818.818 8.896 4.62 19.68 6.496C228.827 306.008 242.429 307 256 307c13.571 0 27.173-.992 37.957-2.867 10.784-1.876 18.862-5.678 19.68-6.496 1.878-1.879 4.809-7.578 6.601-15.198C322.031 274.82 323 265.4 323 256c0-9.4-.969-18.82-2.762-26.44-1.792-7.619-4.723-13.318-6.601-15.197-.818-.818-8.896-4.62-19.68-6.496C283.173 205.992 269.571 205 256 205z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
