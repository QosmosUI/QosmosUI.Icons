// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiDozen : ComponentBase
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
		builder.AddAttribute(14, "d", "M64.865 21.293c-11.48 0-20.785 10.696-20.785 23.887 0 8.72 4.068 16.345 10.14 20.515H15.308v18.688h40.228v23.365l-24.56 49.422 16.736 8.318 17.17-34.547 17.167 34.548 16.736-8.318-24.56-49.422V84.383h40.228V65.695H75.51c6.072-4.17 10.14-11.796 10.14-20.515 0-13.193-9.305-23.887-20.785-23.887zm126.895 0c-11.48 0-20.785 10.696-20.785 23.887 0 8.72 4.068 16.345 10.14 20.515H142.2v18.688h40.23v23.365l-24.56 49.422 16.735 8.318 17.168-34.547 17.168 34.548 16.738-8.318-24.56-49.422V84.383h40.228V65.695h-38.942c6.073-4.17 10.14-11.796 10.14-20.515 0-13.193-9.305-23.887-20.784-23.887zm123.244 0c-11.48 0-20.785 10.696-20.785 23.887 0 8.72 4.067 16.345 10.14 20.515h-38.913v18.688h40.227v23.365l-24.56 49.422 16.736 8.318 17.17-34.55 17.168 34.55 16.734-8.318-24.56-49.418v-23.37h40.228V65.696h-38.94c6.073-4.17 10.14-11.796 10.14-20.515 0-13.193-9.307-23.887-20.786-23.887zm122.164 0c-11.48 0-20.785 10.696-20.785 23.887 0 8.72 4.068 16.345 10.14 20.515H387.61v18.688h40.228v23.365l-24.56 49.422 16.736 8.318 17.168-34.547 17.168 34.548 16.736-8.318-24.56-49.418v-23.37h40.228V65.696h-38.94c6.073-4.17 10.14-11.796 10.14-20.515 0-13.193-9.307-23.887-20.786-23.887zM64.865 187.153c-11.48 0-20.785 10.697-20.785 23.888 0 8.72 4.067 16.344 10.14 20.515H15.306v18.69h40.228v23.364l-24.56 49.42 16.736 8.318L64.88 296.8l17.167 34.548 16.736-8.317-24.56-49.42v-23.366h40.228v-18.69H75.513c6.07-4.17 10.138-11.794 10.138-20.513 0-13.192-9.305-23.886-20.785-23.886zm126.895 0c-11.48 0-20.785 10.697-20.785 23.888 0 8.72 4.067 16.344 10.138 20.515H142.2v18.69h40.23v23.364l-24.56 49.42 16.735 8.318 17.168-34.547 17.168 34.548 16.738-8.317-24.56-49.42v-23.366h40.228v-18.69h-38.94c6.072-4.17 10.14-11.794 10.14-20.513 0-13.192-9.307-23.886-20.786-23.886zm123.244 0c-11.48 0-20.785 10.697-20.785 23.888 0 8.72 4.066 16.344 10.137 20.515h-38.91v18.69h40.227v23.364l-24.56 49.42 16.736 8.318 17.17-34.547 17.168 34.548 16.734-8.317-24.56-49.417v-23.37h40.228v-18.688h-38.938c6.072-4.17 10.14-11.795 10.14-20.514 0-13.192-9.31-23.886-20.788-23.886zm122.164 0c-11.48 0-20.785 10.697-20.785 23.888 0 8.72 4.067 16.344 10.138 20.515h-38.91v18.69h40.228v23.364l-24.56 49.42 16.736 8.318 17.168-34.547 17.168 34.548 16.736-8.317-24.56-49.417v-23.37h40.228v-18.688h-38.938c6.072-4.17 10.14-11.795 10.14-20.514 0-13.192-9.31-23.886-20.788-23.886zM64.865 352.43c-11.48 0-20.785 10.695-20.785 23.886 0 8.72 4.067 16.345 10.14 20.516H15.306v18.69h40.228v23.365l-24.56 49.422 16.736 8.315 17.17-34.547 17.167 34.547 16.736-8.316-24.56-49.423V415.52h40.228v-18.688H75.513c6.07-4.17 10.138-11.797 10.138-20.516 0-13.192-9.305-23.886-20.785-23.886zm126.895 0c-11.48 0-20.785 10.695-20.785 23.886 0 8.72 4.067 16.345 10.138 20.516H142.2v18.69h40.23v23.365l-24.56 49.422 16.735 8.315 17.168-34.547 17.168 34.547 16.738-8.316-24.56-49.423V415.52h40.228v-18.688h-38.94c6.072-4.17 10.14-11.797 10.14-20.516 0-13.192-9.307-23.886-20.786-23.886zm123.244 0c-11.48 0-20.785 10.695-20.785 23.886 0 8.72 4.066 16.345 10.137 20.516h-38.91v18.69h40.227v23.365l-24.56 49.422 16.736 8.315 17.17-34.547 17.168 34.547 16.734-8.316-24.56-49.42v-23.37h40.228v-18.688h-38.938c6.072-4.17 10.14-11.797 10.14-20.516 0-13.192-9.31-23.886-20.788-23.886zm122.164 0c-11.48 0-20.785 10.695-20.785 23.886 0 8.72 4.067 16.345 10.138 20.516h-38.91v18.69h40.228v23.365l-24.56 49.422 16.736 8.315 17.168-34.547 17.168 34.547 16.736-8.316-24.56-49.42v-23.37h40.228v-18.688h-38.938c6.072-4.17 10.14-11.797 10.14-20.516 0-13.192-9.31-23.886-20.788-23.886z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
